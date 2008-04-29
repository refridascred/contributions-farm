-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, score, ratio) VALUES ('staging', 20.61, 76.98);
INSERT INTO layout_items (token, score, ratio) VALUES ('strict', 20.41, 57.56);
