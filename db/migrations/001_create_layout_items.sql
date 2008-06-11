-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, score, level, label, region) VALUES ('open', 8.9, 30, 'primary', 'primary');
INSERT INTO layout_items (owner, score, level, label, region) VALUES ('legacy', 93.82, 2, 'fallback', 'fallback');
INSERT INTO layout_items (owner, score, level, label, region) VALUES ('open', 12.92, 55, 'standard', 'latest');
