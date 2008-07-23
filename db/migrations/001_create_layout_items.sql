-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, count, score) VALUES ('staging', 'latest', 8, 59.6);
INSERT INTO layout_items (region, state, count, score) VALUES ('green', 'open', 0, 14.27);
INSERT INTO layout_items (region, state, count, score) VALUES ('green', 'open', 78, 47.41);
