-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, weight, owner, score) VALUES (80, 18.19, 'primary', 45.61);
INSERT INTO layout_items (level, weight, owner, score) VALUES (79, 21.56, 'fallback', 93.07);
