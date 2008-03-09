-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, rank, token, label, level) VALUES ('standard', 60, 'blue', 'green', 18);
INSERT INTO layout_items (owner, rank, token, label, level) VALUES ('cached', 63, 'stable', 'local', 26);
INSERT INTO layout_items (owner, rank, token, label, level) VALUES ('fallback', 57, 'latest', 'eu-west', 32);
