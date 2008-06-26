-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, state, level) VALUES ('edge', 'strict', 69);
INSERT INTO layout_items (region, state, level) VALUES ('primary', 'blue', 49);
INSERT INTO layout_items (region, state, level) VALUES ('open', 'stable', 81);
