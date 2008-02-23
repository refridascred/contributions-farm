-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (state, ratio, owner, level) VALUES ('standard', 17.46, 'strict', 88);
INSERT INTO layout_items (state, ratio, owner, level) VALUES ('strict', 34.51, 'stable', 14);
INSERT INTO layout_items (state, ratio, owner, level) VALUES ('cached', 71.69, 'latest', 2);
