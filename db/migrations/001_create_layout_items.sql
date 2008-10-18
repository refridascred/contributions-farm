-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, active, token) VALUES (62.27, 37, 'latest');
INSERT INTO layout_items (ratio, active, token) VALUES (93.15, 38, 'local');
INSERT INTO layout_items (ratio, active, token) VALUES (50.32, 77, 'open');
