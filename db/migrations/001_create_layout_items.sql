-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, ratio, count, label, token) VALUES ('blue', 16.36, 35, 'fallback', 'latest');
INSERT INTO layout_items (owner, ratio, count, label, token) VALUES ('primary', 55.79, 32, 'open', 'local');
