-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (state, token, owner, level, count) VALUES ('edge', 'legacy', 'local', 81, 19);
INSERT INTO layout_items (state, token, owner, level, count) VALUES ('open', 'local', 'primary', 57, 12);
INSERT INTO layout_items (state, token, owner, level, count) VALUES ('local', 'primary', 'primary', 41, 61);
