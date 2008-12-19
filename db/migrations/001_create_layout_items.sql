-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (token, active, count, weight, region) VALUES ('staging', 82, 72, 55.29, 'strict');
INSERT INTO layout_items (token, active, count, weight, region) VALUES ('fallback', 45, 2, 37.61, 'open');
