-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, score, level, token, owner) VALUES ('latest', 5.39, 97, 'green', 'stable');
INSERT INTO layout_items (region, score, level, token, owner) VALUES ('latest', 66.45, 13, 'latest', 'legacy');
INSERT INTO layout_items (region, score, level, token, owner) VALUES ('legacy', 32.1, 94, 'edge', 'edge');
