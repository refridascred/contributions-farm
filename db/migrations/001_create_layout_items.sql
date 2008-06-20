-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, score, count, region) VALUES ('fallback', 23.64, 77.76, 56, 'open');
INSERT INTO layout_items (owner, ratio, score, count, region) VALUES ('fallback', 60.07, 27.39, 11, 'stable');
