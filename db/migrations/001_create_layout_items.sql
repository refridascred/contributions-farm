-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, active, region, count, ratio) VALUES ('fallback', 92, 'primary', 74, 4.02);
INSERT INTO layout_items (token, active, region, count, ratio) VALUES ('primary', 40, 'blue', 16, 76.23);
