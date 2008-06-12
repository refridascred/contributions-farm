-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (token, score) VALUES ('open', 72.21);
INSERT INTO layout_items (token, score) VALUES ('eu-west', 21.6);
INSERT INTO layout_items (token, score) VALUES ('cached', 15.47);
