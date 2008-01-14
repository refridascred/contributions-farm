-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (ratio, token, rank, score) VALUES (10.66, 'stable', 70, 86.25);
INSERT INTO layout_items (ratio, token, rank, score) VALUES (1.55, 'eu-west', 57, 84.54);
