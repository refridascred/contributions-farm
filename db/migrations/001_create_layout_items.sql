-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (count, owner, ratio, state, level) VALUES (10, 'green', 34.0, 'edge', 45);
INSERT INTO layout_items (count, owner, ratio, state, level) VALUES (71, 'open', 12.51, 'eu-west', 88);
INSERT INTO layout_items (count, owner, ratio, state, level) VALUES (52, 'latest', 7.96, 'standard', 96);
