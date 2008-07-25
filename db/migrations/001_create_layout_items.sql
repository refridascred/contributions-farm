-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, state, level) VALUES ('local', 'standard', 75);
INSERT INTO layout_items (region, state, level) VALUES ('open', 'legacy', 34);
INSERT INTO layout_items (region, state, level) VALUES ('edge', 'primary', 94);
