-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, score, weight, count) VALUES ('staging', 61.64, 24.75, 57);
INSERT INTO layout_items (token, score, weight, count) VALUES ('fallback', 65.69, 87.92, 24);
INSERT INTO layout_items (token, score, weight, count) VALUES ('open', 89.43, 29.61, 27);
