-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, weight, count) VALUES (95.24, 'open', 30.33, 16);
INSERT INTO layout_items (score, token, weight, count) VALUES (18.48, 'staging', 38.61, 35);
