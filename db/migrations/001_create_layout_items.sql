-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, rank, score, owner) VALUES ('primary', 55, 29.25, 'cached');
INSERT INTO layout_items (token, rank, score, owner) VALUES ('blue', 62, 69.39, 'edge');
