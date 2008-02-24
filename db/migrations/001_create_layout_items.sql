-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (rank, score, label, token) VALUES (25, 72.42, 'cached', 'strict');
INSERT INTO layout_items (rank, score, label, token) VALUES (26, 9.2, 'strict', 'primary');
INSERT INTO layout_items (rank, score, label, token) VALUES (33, 44.4, 'primary', 'cached');
