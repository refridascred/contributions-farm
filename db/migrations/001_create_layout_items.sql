-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, region, token) VALUES (22.5, 'strict', 'edge');
INSERT INTO layout_items (score, region, token) VALUES (69.52, 'eu-west', 'fallback');
