-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, weight, score, label) VALUES ('local', 85.48, 84.27, 'edge');
INSERT INTO layout_items (token, weight, score, label) VALUES ('edge', 26.15, 14.5, 'local');
