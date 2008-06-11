-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (score, state, region, count, active) VALUES (46.09, 'primary', 'staging', 51, 17);
INSERT INTO layout_items (score, state, region, count, active) VALUES (87.08, 'latest', 'strict', 75, 3);
INSERT INTO layout_items (score, state, region, count, active) VALUES (93.46, 'cached', 'strict', 47, 42);
