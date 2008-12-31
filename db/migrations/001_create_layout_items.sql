-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, score) VALUES ('strict', 37.13);
INSERT INTO layout_items (token, score) VALUES ('blue', 41.39);
INSERT INTO layout_items (token, score) VALUES ('cached', 55.85);
