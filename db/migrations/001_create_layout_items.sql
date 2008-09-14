-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, owner, count, ratio, token) VALUES (52, 'cached', 86, 25.09, 'standard');
INSERT INTO layout_items (level, owner, count, ratio, token) VALUES (14, 'staging', 55, 68.85, 'latest');
INSERT INTO layout_items (level, owner, count, ratio, token) VALUES (82, 'latest', 20, 26.76, 'open');
