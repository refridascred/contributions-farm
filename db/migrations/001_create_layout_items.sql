-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, rank, label, count) VALUES (47, 2, 'cached', 16);
INSERT INTO layout_items (active, rank, label, count) VALUES (28, 19, 'legacy', 71);
INSERT INTO layout_items (active, rank, label, count) VALUES (0, 49, 'stable', 59);
