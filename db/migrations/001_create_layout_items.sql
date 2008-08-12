-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (state, region, level, weight) VALUES ('edge', 'fallback', 12, 24.96);
INSERT INTO layout_items (state, region, level, weight) VALUES ('blue', 'primary', 34, 67.18);
