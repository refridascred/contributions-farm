-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, level, count, region) VALUES ('eu-west', 90, 8, 'green');
INSERT INTO layout_items (state, level, count, region) VALUES ('edge', 93, 91, 'local');
INSERT INTO layout_items (state, level, count, region) VALUES ('strict', 97, 66, 'legacy');
