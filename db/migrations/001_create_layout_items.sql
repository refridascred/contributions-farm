-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (state, active, token, level, count) VALUES ('stable', 72, 'stable', 43, 28);
INSERT INTO layout_items (state, active, token, level, count) VALUES ('primary', 66, 'blue', 65, 12);
INSERT INTO layout_items (state, active, token, level, count) VALUES ('latest', 72, 'strict', 28, 47);
