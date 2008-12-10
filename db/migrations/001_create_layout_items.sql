-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, active, ratio, token) VALUES ('primary', 34, 32.93, 'edge');
INSERT INTO layout_items (region, active, ratio, token) VALUES ('eu-west', 29, 29.72, 'edge');
