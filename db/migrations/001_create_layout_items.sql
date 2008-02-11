-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner, region, score, level) VALUES ('standard', 'strict', 'green', 43.47, 14);
INSERT INTO layout_items (token, owner, region, score, level) VALUES ('latest', 'cached', 'legacy', 74.94, 43);
