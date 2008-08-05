-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, weight, region, token) VALUES (66, 4.94, 'fallback', 'legacy');
INSERT INTO layout_items (active, weight, region, token) VALUES (81, 73.56, 'stable', 'green');
