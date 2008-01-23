-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (score, token, weight) VALUES (26.38, 'eu-west', 37.44);
INSERT INTO layout_items (score, token, weight) VALUES (1.69, 'strict', 58.48);
INSERT INTO layout_items (score, token, weight) VALUES (17.07, 'local', 68.83);
