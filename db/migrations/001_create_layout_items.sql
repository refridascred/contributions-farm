-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, label, score) VALUES (63, 'latest', 41.63);
INSERT INTO layout_items (rank, label, score) VALUES (23, 'open', 37.89);
INSERT INTO layout_items (rank, label, score) VALUES (91, 'cached', 98.88);
