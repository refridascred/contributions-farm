-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (level, active, state, ratio) VALUES (85, 37, 'stable', 17.57);
INSERT INTO layout_items (level, active, state, ratio) VALUES (63, 94, 'latest', 63.14);
INSERT INTO layout_items (level, active, state, ratio) VALUES (69, 7, 'local', 43.07);
