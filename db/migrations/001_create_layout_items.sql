-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, level, region, state) VALUES ('eu-west', 67, 'edge', 'open');
INSERT INTO layout_items (owner, level, region, state) VALUES ('green', 10, 'strict', 'standard');
INSERT INTO layout_items (owner, level, region, state) VALUES ('edge', 7, 'green', 'strict');
