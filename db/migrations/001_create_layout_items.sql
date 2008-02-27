-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score, state, level, active) VALUES ('cached', 48.86, 'local', 65, 88);
INSERT INTO layout_items (owner, score, state, level, active) VALUES ('eu-west', 58.98, 'primary', 0, 91);
INSERT INTO layout_items (owner, score, state, level, active) VALUES ('latest', 1.56, 'eu-west', 9, 45);
