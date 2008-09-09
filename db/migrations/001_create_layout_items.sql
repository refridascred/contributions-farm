-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, level, label, owner) VALUES (30.17, 13.09, 14, 'fallback', 'open');
INSERT INTO layout_items (ratio, score, level, label, owner) VALUES (47.35, 15.64, 9, 'primary', 'stable');
INSERT INTO layout_items (ratio, score, level, label, owner) VALUES (38.02, 81.48, 86, 'fallback', 'staging');
