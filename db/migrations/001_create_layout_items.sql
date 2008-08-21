-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, label, rank, ratio) VALUES ('blue', 'fallback', 23, 4.0);
INSERT INTO layout_items (token, label, rank, ratio) VALUES ('standard', 'primary', 23, 54.68);
INSERT INTO layout_items (token, label, rank, ratio) VALUES ('stable', 'green', 49, 4.66);
