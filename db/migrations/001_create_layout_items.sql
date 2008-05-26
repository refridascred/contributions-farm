-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, state, token, level, ratio) VALUES ('staging', 'staging', 'cached', 70, 25.19);
INSERT INTO layout_items (owner, state, token, level, ratio) VALUES ('blue', 'staging', 'open', 54, 49.25);
INSERT INTO layout_items (owner, state, token, level, ratio) VALUES ('cached', 'latest', 'stable', 48, 29.78);
