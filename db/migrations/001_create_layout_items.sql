-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (level, label, count) VALUES (91, 'green', 18);
INSERT INTO layout_items (level, label, count) VALUES (79, 'latest', 58);
INSERT INTO layout_items (level, label, count) VALUES (22, 'strict', 65);
