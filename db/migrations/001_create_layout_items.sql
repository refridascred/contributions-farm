-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, count, weight, label) VALUES ('primary', 43, 12.45, 'blue');
INSERT INTO layout_items (token, count, weight, label) VALUES ('blue', 3, 72.43, 'blue');
INSERT INTO layout_items (token, count, weight, label) VALUES ('green', 18, 40.66, 'open');
