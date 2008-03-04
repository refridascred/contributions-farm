-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, label, ratio, count) VALUES ('standard', 'edge', 66.78, 23);
INSERT INTO layout_items (owner, label, ratio, count) VALUES ('cached', 'staging', 45.71, 35);
