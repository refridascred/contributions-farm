-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, label, owner) VALUES (47, 11, 'edge', 'latest');
INSERT INTO layout_items (active, count, label, owner) VALUES (20, 64, 'blue', 'legacy');
INSERT INTO layout_items (active, count, label, owner) VALUES (51, 59, 'blue', 'cached');
