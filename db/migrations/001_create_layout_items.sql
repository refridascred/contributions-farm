-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, label, rank) VALUES (56, 'staging', 32);
INSERT INTO layout_items (count, label, rank) VALUES (32, 'stable', 14);
INSERT INTO layout_items (count, label, rank) VALUES (87, 'standard', 0);
