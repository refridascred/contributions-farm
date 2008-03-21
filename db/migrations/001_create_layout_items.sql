-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, token, rank, score) VALUES (13.97, 'primary', 32, 20.25);
INSERT INTO layout_items (ratio, token, rank, score) VALUES (67.16, 'standard', 51, 76.86);
