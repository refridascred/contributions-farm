-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, token, weight) VALUES (16.98, 'eu-west', 70.27);
INSERT INTO layout_items (score, token, weight) VALUES (68.24, 'latest', 35.77);
INSERT INTO layout_items (score, token, weight) VALUES (81.18, 'edge', 20.17);
