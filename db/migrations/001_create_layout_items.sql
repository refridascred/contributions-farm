-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, token, rank, label) VALUES ('staging', 'strict', 69, 'eu-west');
INSERT INTO layout_items (owner, token, rank, label) VALUES ('standard', 'primary', 72, 'stable');
