-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, token, count) VALUES ('latest', 'staging', 'standard', 98);
INSERT INTO layout_items (region, state, token, count) VALUES ('stable', 'blue', 'edge', 92);
INSERT INTO layout_items (region, state, token, count) VALUES ('strict', 'legacy', 'staging', 81);
