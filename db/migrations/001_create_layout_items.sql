-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (label, count, region, state, owner) VALUES ('latest', 50, 'strict', 'staging', 'cached');
INSERT INTO layout_items (label, count, region, state, owner) VALUES ('stable', 81, 'strict', 'staging', 'open');
