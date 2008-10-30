-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, label, level, region) VALUES (42.27, 'green', 59, 'edge');
INSERT INTO layout_items (score, label, level, region) VALUES (61.42, 'local', 22, 'green');
INSERT INTO layout_items (score, label, level, region) VALUES (75.72, 'local', 84, 'local');
