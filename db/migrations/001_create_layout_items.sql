-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, label, count, level) VALUES (87, 'local', 28, 92);
INSERT INTO layout_items (rank, label, count, level) VALUES (97, 'eu-west', 84, 65);
INSERT INTO layout_items (rank, label, count, level) VALUES (97, 'strict', 62, 7);
