-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, label, ratio, rank) VALUES (31, 'legacy', 91.41, 7);
INSERT INTO layout_items (active, label, ratio, rank) VALUES (57, 'strict', 41.02, 79);
INSERT INTO layout_items (active, label, ratio, rank) VALUES (42, 'local', 6.61, 99);
