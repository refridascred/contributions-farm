-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, count, label, score) VALUES (20.79, 6, 'latest', 66.04);
INSERT INTO layout_items (weight, count, label, score) VALUES (85.62, 6, 'strict', 10.43);
INSERT INTO layout_items (weight, count, label, score) VALUES (35.5, 73, 'primary', 73.17);
