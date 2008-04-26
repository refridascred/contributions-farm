-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (region, active, token, count) VALUES ('legacy', 89, 'open', 47);
INSERT INTO layout_items (region, active, token, count) VALUES ('fallback', 32, 'strict', 33);
INSERT INTO layout_items (region, active, token, count) VALUES ('primary', 85, 'fallback', 30);
