-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, count, score) VALUES ('edge', 95, 95.0);
INSERT INTO layout_items (token, count, score) VALUES ('edge', 77, 40.43);
INSERT INTO layout_items (token, count, score) VALUES ('green', 52, 84.67);
