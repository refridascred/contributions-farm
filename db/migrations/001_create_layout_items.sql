-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, score, token, region, active) VALUES ('fallback', 73.78, 'blue', 'local', 45);
INSERT INTO layout_items (label, score, token, region, active) VALUES ('local', 47.13, 'primary', 'staging', 58);
INSERT INTO layout_items (label, score, token, region, active) VALUES ('edge', 88.25, 'fallback', 'green', 95);
