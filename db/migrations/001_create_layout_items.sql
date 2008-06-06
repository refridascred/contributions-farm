-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (score, region, state, count) VALUES (5.14, 'latest', 'primary', 93);
INSERT INTO layout_items (score, region, state, count) VALUES (50.19, 'primary', 'stable', 74);
INSERT INTO layout_items (score, region, state, count) VALUES (44.38, 'stable', 'green', 32);
