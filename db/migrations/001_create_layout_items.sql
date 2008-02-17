-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (count, rank, label) VALUES (60, 84, 'stable');
INSERT INTO layout_items (count, rank, label) VALUES (19, 97, 'fallback');
INSERT INTO layout_items (count, rank, label) VALUES (67, 34, 'fallback');
