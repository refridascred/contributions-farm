-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (rank, score, token, label) VALUES (21, 97.91, 'edge', 'primary');
INSERT INTO layout_items (rank, score, token, label) VALUES (0, 80.06, 'green', 'latest');
INSERT INTO layout_items (rank, score, token, label) VALUES (33, 69.49, 'fallback', 'strict');
