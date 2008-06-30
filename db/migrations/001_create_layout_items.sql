-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, token, label, rank) VALUES (10, 'local', 'standard', 30);
INSERT INTO layout_items (count, token, label, rank) VALUES (47, 'local', 'cached', 5);
INSERT INTO layout_items (count, token, label, rank) VALUES (43, 'fallback', 'primary', 35);
