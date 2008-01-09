-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, rank, count, label) VALUES (56.22, 94, 54, 'strict');
INSERT INTO layout_items (weight, rank, count, label) VALUES (9.48, 54, 85, 'edge');
INSERT INTO layout_items (weight, rank, count, label) VALUES (62.93, 44, 74, 'primary');
