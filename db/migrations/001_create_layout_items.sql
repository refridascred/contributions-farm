-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, token, ratio, label) VALUES (1.87, 'blue', 65.01, 'latest');
INSERT INTO layout_items (score, token, ratio, label) VALUES (54.58, 'latest', 16.2, 'strict');
